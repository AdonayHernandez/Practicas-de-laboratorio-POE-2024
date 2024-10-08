﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class CareerServices
    {
        private CareerRepository _careerRepository;

        public CareerServices()
        {
            _careerRepository = new CareerRepository();
        }
        public DataTable GetAllCareers()
        {
            return _careerRepository.GetCareers();
        }
        public void AddCareer(Career career) 
        {
            _careerRepository.AddCareer(career);    
        }
        public void UpdateCareer(Career career) 
        {
            _careerRepository.EditCareer(career);
        }
        public void DeleteCareer(int id) 
        {
            _careerRepository.DeleteCareer(id);
        }
    }
}
