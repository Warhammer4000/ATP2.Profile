﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.UserRepository;
using Entity.Data;
using Entity.UserModels;

namespace BLL.SearchRepository
{
    public class PublicSearch
    {
        public List<Tutor> SearchTutors(Location location,string gender,string Class,
            int salaryMin,int salaryMax,List<Subject> selectedSubjects)
        {
            List<Tutor> searchResult=new TutorRepository().GetAll();

            searchResult = searchResult.Where(r => r.ExpectedSalary >= salaryMin 
            && r.ExpectedSalary <= salaryMax
            && r.Gender==gender 
            && r.PreferredLocations.Contains(location) 
            && r.PreferredClasses.Contains(Class)
            &&r.PreferredSubjects.Intersect(selectedSubjects).Any()
            ).ToList();

           

            return  searchResult;
        }


    }
}