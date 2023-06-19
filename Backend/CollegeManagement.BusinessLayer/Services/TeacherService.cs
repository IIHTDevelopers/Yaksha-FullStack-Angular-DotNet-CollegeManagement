﻿using CollegeManagement.BusinessLayer.Interfaces;
using CollegeManagement.BusinessLayer.Services.Repository;
using CollegeManagement.BusinessLayer.ViewModels;
using CollegeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.BusinessLayer.Services
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<Teacher> CreateTeacher(Teacher teacher)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTeacherById(long teacherId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> GetTeacherById(long teacherId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> SearchTeacherByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Teacher> UpdateTeacher(TeacherViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
