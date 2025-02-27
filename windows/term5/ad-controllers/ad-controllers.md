# Управление контроллерами домена в Active Directory

## Цель работы:

Получить дополнительные навыки по управлению контроллерами домена Active Directory на основе Windows
Server, работу с событиями и процессами.

Необходимо:

- Установленная на компьютере среда виртуализации ORACLE Virtual Box
- Образы виртуальных жёстких дисков операционных систем Windows Server 2012/2016.
- Доступ к Microsoft Evaluation Center (https://www.microsoft.com/ru-ru/evalcenter)

## Краткие теоретические сведения:

Основной единицей хранения в AD является домен. Домен – контейнерный объект, представляющий собой фрагмент AD хранящийся
на специальном компьютере с Windows Server. Домен может содержать объекты-контейнеры (Organization Unit) и конечные
объекты (User, Group, Computer и т.п.). Домены AD могут объединяться в деревья, деревья в конгломераты более высокого
уровня – леса. В AD относительно домена может сроиться распределенная система в которых копии домена хранятся на
нескольких Windows Server, работающих в режиме контроллера домена.

Служба Active Directory Service является распределенной. Домен хранится на одном или нескольких контроллерах
доменов, которые являются равнозначными.

Однако существуют особые роли контроллеров домена – FSMO и функция глобального каталога. Эту функцию и каждую из ролей
выполняет единственный контроллер. FSMO и функция глобального каталога могут быть перенесены или принудительно
захвачены.

> Советы:
> - После выполнения работы необходимо сохранить снимки состояния виртуальных машин, для использования в
    последующих работах.
> - Перед выполнением работы ознакомитесь с требованиями к содержанием отчета, чтобы собирать необходимые артефакты
    выполнения.

## Порядок выполнения работы:

### Часть 1. Подготовительная.

- Для выполнения работы понадобится две виртуальные машины Windows Server и Windows 10 Pro или Enterprise и Windows
  Server одной из версий: 2012 R2\2016\2019.
- Дистрибутивы операционных систем со сроком действия 90 дней можно скачать с сайта Microsoft Evaluation
  Center (https://www.microsoft.com/ru-ru/evalcenter).
- Для выполнения работы вы можете использовать готовую инфраструктуру из работы №2.
- Если таковая инфраструктура имеется, установите дополнительный Windows Server с именем as-srv-2 со статическим адресом
  и в той же локальной сети, что и предыдущие машины. Введите его в домен.
- Если инфраструктуры нет, то:
    - Подготовьте виртуальные машины с windows server ad-srv и as-srv-2, и ad-client c Windows 10.
    - Настройте виртуальные машины так, чтобы они оказались в одной, изолированной LAN. Для сервера выберите и настройте
      адрес из сети 10.0.0.0/8. В качестве DNS севера установите адресе сервера ad-srv.
    - Подготовьте компьютер «AD-Srv» к развертыванию AD (новый домен, новый лес) с установкой DNS на «Ad-srv». С помощью
      мастера добавления ролей и компонентов и диспетчера серверов развернуть домен с именем: «ваши_FIO».local.
      Автоматически
      установите и настройте DNS.
    - Введите в домен as-srv-2 и ad-client
- Сделайте снапшоты всех машин.

### Часть 2. Добавление контроллера домена

- На компьютере ad-srv-2 установите роль AD DS.
- Настройте на нем дополнительный контроллер домена в том же лесу, домене.
- После установки перезагрузить компьютер.

### Часть 3. Получение информации о домене

- С помощью PowerShell установите, на каком контроллере домена функционируют FSMO
- С помощью dsquery установите, на каком контроллере домена функционируют FSMO
  _ Выясните, какие записи DNS появились с вводом нового контроллера домена.
- На контроллере ad-srv-2 создайте пользователя в AD. Убедитесь, что от имени этого пользователя можно запускать
  процессы на ad-client с помощью GUI, утилиты runas и PowerShell.

### Часть 4. Архивация Active Directory

- С помощью PowerShell установите службу архивации windows на ad-srv.
- С помощью консольной утилиты wbadmin создайте архивную копию ActiveDirectory.

### Часть 5. Замена контроллера домена

Реализуйте сценарий замены контроллера домена, при котором все роли и gc будут переданы на ad-srv-2, а роль AD DS
будет удалена с ad-srv.

- Создайте снапшоты всех виртуальных машин.
- Перенесите FSMO и gc на ad-srv-2 или с помощью утилиты ntdsutil, PowerShell или GUI. Убедитесь, что перенесен и DNS.
- Подготовьте описание процесса для отчета.
- С помощью утилиты dcdiag проверьте AD на ошибки.
- С помощью PowerShell установите, на каком контроллере домена функционируют FSMO
- Удалите роль AD DS на ad-srv. Перегрузите компьютер.
- С помощью утилиты dcdiag проверьте AD на ошибки.
- Убедитесь, что пользователи могут регистрироваться на ad-client.

### Содержание отчета

Требуется подготовить отчеты в формате DOC\DOCX или PDF. Отчет содержит титульный лист, артефакты выполнения и ответы на
вопросы.

Вопросы:

- Перечислите FSMO. Кратко раскройте их назначение.
- Опишите, что произойдет, если не будет доступна каждая из ролей.
- Как с помощью утилиты dcdiag проверить корректность настройки только dns?
- Как с помощью утилиты dcdiag исправить ошибки в конфигурации?
- Как ввести компьютер в домен с помощью утилиты netdom?
- Как ввести компьютер в домен с помощью утилиты PowerShell?
- Как запустить процесс от имени другого пользователя с помощью утилиты runas?
- Как запустить процесс от имени другого пользователя с помощью командлета Invoke-Command?

Артефакты:

- Консольные выводы по Части 3, п. 1-2.
- Ответ на вопрос из Части 3., п. 3.
- Командные строки из Части 4, п. 1-2.
- Приведите описание процесса переноса ролей из Части 5. п.2
- Командные строки и консольный вывод из Части 5, п. 5.



