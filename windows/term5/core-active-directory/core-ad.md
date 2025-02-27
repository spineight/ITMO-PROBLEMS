# Основы работы с Active Directory в Windows Server.

## Цель работы:

Получить базовые навыки развертывания службы каталогов Active Directory на основе Windows Server,
управления объектами AD, их правами и групповыми политиками.

Необходимо:

- Установленная на компьютере среда виртуализации ORACLE Virtual Box
- Образы виртуальных жёстких дисков операционных систем Windows Server 2012 R2/2016/2019.
- Доступ к Microsoft Evaluation Center (https://www.microsoft.com/ru-ru/evalcenter)

## Краткие теоретические сведения:

Для централизованного управления ресурсами сети применяют распределенные системы – службы каталогов. Эти системы
позволяют хранить данные об объектах и субъектах безопасности в специализированной распределенной, защищенной базе
данных - службе каталогов. На рынке существуют несколько популярных служб каталогов. Например, Novell eDirectory,
OpenLDAP и Microsoft Active Directory (далее AD). Последняя является службой каталогов для сетей Windows. Структурно AD
построена по принципу DNS и имеет подобную древовидную структуру. Сама AD использует механизмы DNS для поиска служб и
организации взаимодействия компонентов сервиса.

Доступ к объектам каталога осуществляется по протоколу LDAP. В службах каталогов присутствуют объекты двух типов -
контейнеры и листья (по ассоциации с деревом).

Основной единицей хранения в AD является домен. Домен – контейнерный объект, представляющий собой фрагмент AD хранящийся
на специальном компьютере с Windows Server. Домен может содержать объекты-контейнеры (Organization Unit) и конечные
объекты (User, Group, Computer и т.п.). Домены AD могут объединяться в деревья, деревья в конгломераты более высокого
уровня – леса. В AD относительно домена может сроиться распределенная система в которых копии домена хранятся на
нескольких Windows Server, работающих в режиме контроллера домена.

Домены и другие контейнеры предназначены для объединения других объектов и распространения групповых политик. Групповые
политики — это шаблоны, которые накладываются на реестр Windows и применяются для ассоциированных с ними объектов. Так,
если в домене firma.loc создан Organization Unit с именем dev , а в нем пользователь supervisor, то при регистрации
пользователя supervisor к его рабочей станции применяются среди прочих, групповые политики, привязанные к контейнеру
dev.

Для управления объектами AD используются средства GUI, консольные утилиты dsquery, dsmod, dsadd, dsrm, dsget и набор
командлетов Power Shell.

Для разграничения прав на доступ к файловым объектам на платформе Windows используется механизм ACL в файловой системе
NTFS, в которой реализована возможность достаточно гибкого управления правами доступа к файлам и каталогам.

> Советы:
> - После выполнения работы необходимо сохранить снимки состояния виртуальных машин, для использования в
    последующих работах.
> - Перед выполнением работы ознакомитесь с требованиями к содержанию отчета, чтобы собирать необходимые артефакты
    выполнения.

## Порядок выполнения работы:

### Часть 1. Подготовительная.

- Для выполнения работы понадобится две виртуальные машины Windows Server и Windows 10 Pro или Enterprise.
- Дистрибутивы операционных систем со сроком действия 90 дней можно скачать с сайта Microsoft Evaluation
  Center (https://www.microsoft.com/ru-ru/evalcenter).
- Установите операционные системы, сделайте снапшоты машин. Переименуйте виртуальные машины в ad-srv, и ad-client
  соответственно версии операционной системы.
- Настройте виртуальные машины так, чтобы они оказались в одной, изолированной LAN. Для сервера выберите и настройте
  адрес из сети 10.0.0.0/8. В качестве DNS севера установите адресе самого сервера.

### Часть 2. Развертывание Active Directory

- Подготовьте компьютер «AD-Srv» к развертыванию AD (новый домен, новый лес) с установкой DNS на «Ad-srv». С помощью
  мастера добавления ролей и компонентов и диспетчера серверов развернуть домен с именем: «ваши_FIO».local.
  Автоматически
  установите и настройте DNS.
- После установки перезагрузить компьютер.
- Установить DHCP-сервер и произвести его настройку (использовать адресный пул 10.0.0.100-10.0.0.110, обеспечьте
  получение клиентами адреса DNS и шлюза равных адресу сервера). Проведите авторизацию DHCP сервера. После установки
  перезагрузить компьютер.
- Убедитесь, что компьютер ad-client получил необходимую конфигурацию ip. Подключите компьютер ad-client к домену.
- Войдите на ad-client с учетной записью администратора домена.
- На контроллере домена ad-srv в оснастке «Active Directory пользователи и компьютеры» найдите объект компьютера
  ad-client и компьютера ad-srv.

### Часть 3. Объектами AD и правами на NTFS и SMB.

- Используя административную оснастку «Active Directory пользователи и компьютеры», создайте в новом домене 2
  подразделения (Organization Unit): ouSellers, ouManagers. В каждом подразделении создайте пользователя: uSeller1,
  uManager1 и группы gSellers и gManagers.
- На сервере на диске С:\ создайте каталог «AllUsers» и дайте всем пользователям домена право на чтение этого каталога.
  В нем создайте каталоги Sellers и Managers, дайте членам групп gSellers и gManagers все права на уровне NTFS для
  соответствующих каталогов кроме возможностей изменения прав и удаления самих каталогов. При этом следует сохранить
  возможность создавать, удалять и модифицировать файлы и каталоги внутри самих каталогов. Создайте каталог
  AllUsers\BlackHole, в который пользователи созданных групп смогли бы копировать файлы "drag-and-drop", но не
  просматривать содержимое. Создайте каталог AllUsers\Common, в который все пользователи домена смогли бы писать файлы,
  но
  удалять смогли бы только свои. Открыть общий доступ через сеть к каталогу AllUsers с необходимыми разрешениями и
  назначить сетевое имя AllUsersCom.
- На диске C: сервера создайте папку UsersHome. Для каждого созданного в п. 1 части 3 пользователя создайте домашнюю
  папку c:\UsersHome\"имя пользователя". Обеспечьте пользователю возможность записи через сеть (протокол SMB) в свой
  домашний каталог, причем имя сетевой папки должно быть скрытым, т.е. при просмотре списка папок компьютера в «Сетевом
  окружении» папку не должно быть видно.
- В свойствах каждого пользователя задайте подключение домашней папки на диск X: и место хранения перемещаемого
  профиля.
  Обратите внимание на то, что необходимо использовать сетевые пути UNC.
- Используя машину «Ad-client», авторизуйтесь в системе под пользователем uSeller1, перегрузить клиентский компьютер,
  выполнить повторную аутентификацию и изучить данные в каталоге x:\_profile.

### Часть 4. Работа с групповыми политиками.

- С помощью консоли Управление групповой политикой измените групповую политику домена, так чтобы пароли могли быть
  длиной 6 символов без контроля сложности.
  Примечание: после создания политики она применяется не мгновенно, а согласно периоду обновления, заданному политикой
  домена. Для принудительного обновления политики можно использовать команду gpupdate.
- Создайте групповую политику для контейнера ouSellers, с помощью которой будет:
- Запрещен доступ к Панели управления,
- Установлена блокировка экрана при периоде неактивности 1 минута, с отключением возможности менять этот параметр.
- Запретить пользователю редактировать реестр
- Скрыть в проводнике диск C:
- Создайте групповую политику в контейнере ouManagers, которая будет определять приложения, которые может запускать
  пользователь:
    - Paint;
    - calc;
    - Notepad.
- Создайте контейнер для объектов – компьютеров и создайте в нем групповую политику, которая:
- отключает сбор и передачу в Microsoft сообщений об ошибках,
- отключит локальные учетные записи Администратор (Administrator)
- запретит пользователю пользоваться механизмом Offline Files
- установит на клиентских компьютерах для всех файловых объектов на диске C:\ следующий ACL  (Администраторы, Система
  – полный доступ, Пользователи домена – чтение, просмотр каталогов, выполнение файлов).
- Создайте отдельную групповую политику с помощью, которой разверните на клиентском компьютере программу 7-zip (
  инсталлятор MSI).
- Проверьте функционирование политик.

### Часть 5. Автоматизация работы с объектами AD

Напишите скрипт на PowerShell, получающий в качестве параметра путь к CSV файлу, содержащему:

- ФИО пользователя,
- Должность
- Название отдела
- E-mail
- Телефон
- Логин
- Пароль
- Имя контейнера, в который надо поместить пользователя
- Список групп, в которые нужно поместить пользователя
- Путь до домашней папки (подключается на диск X:).
- Путь до перемещаемого профиля.
- Скрипт читает файл и создает необходимые объекты.
- Существование групп и контейнеров необходимо проверять и создавать их в случае отсутствия.
- Скрипт создает все необходимые каталоги, в случае их отсутствия, назначает необходимые права NTFS и включает сетевой
  доступ
- Формирует в формате HTML отчет, в котором указано сколько и каких групп, контейнеров и пользователей создано.
- Все объекты создаются в домене, в котором запущен скрипт.

### Часть 6. Восстановление удаленных объектов

- Включите корзину AD (с помощью PowerShell или Центра администрирования AD).
- С помощью скрипта из части 5 создайте 5 пользователей в контейнере unit-for-delete.
- С помощью команд dsquery и dsrm удалите всех пользователей в контейнере unit-for-delete.
- С помощью PowerShell восстановите всех удаленных пользователей в контейнере unit-for-delete.

## Содержание отчета

Требуется подготовить отчеты в формате DOC\DOCX или PDF.

Отчет содержит титульный лист, артефакты выполнения и ответы на вопросы:

- Раскройте смысл терминов дерево доменов, лес и схема Active Directory?
- Где на контроллере домена хранится данные об объектах Active Directory в виде файлов? Какие файлы за что отвечают?
- Где на контроллере домена хранятся файлы, содержащие групповые политики домена?
- Какие компоненты автоматически устанавливаются мастером при добавлении ролей Active Directory?
- Для чего нужен пароль DSRM?
- Как восстановить пароль DSRM, если он был утерян после установки?
- Зачем нужно имя домена NetBIOS?
- Какие группы пользователей создаются в AD автоматически? Опишите минимум 5 из них.
- Какие записи в DNS создаются специально для AD? Перечислите их, укажете их назначение.

Артефакты:

- Приведите скриншоты групповых политик AD из части 4.
- Приведите скрипт из части 5.
- Как с помощью Powershell восстановить удаленный объект AD?
- Приведите конвейер команд из ч.6 п.3
- Приведите конвейер команд из ч.6 п.4


