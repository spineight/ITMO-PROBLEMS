﻿using System.Collections.Generic;
using IsuExtra.Classes.Standard;

namespace IsuExtra.Interfaces
{
    public interface IIsuService
    {
        Group AddGroup(GroupName name);
        Student AddStudent(Group group, string name);
        Student GetStudent(uint id);
        Student FindStudent(string name);
        List<Student> FindStudents(GroupName groupName);
        List<Student> FindStudents(uint courseNumber);
        Group FindGroup(GroupName groupName);
        List<Group> FindGroups(uint courseNumber);
        void ChangeStudentGroup(Student student, Group newGroup);
    }
}