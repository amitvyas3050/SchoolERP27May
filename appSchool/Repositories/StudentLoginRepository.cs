﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appSchool.ViewModels;
using System.ComponentModel.DataAnnotations;
using appSchool.Controllers;


namespace appSchool.Repositories
{
    public class StudentLoginRepository : GenericRepository<StudentLogin> 
    {
        public StudentLoginRepository() : base(new dbSchoolAppEntities()) { }
        public StudentLoginRepository(dbSchoolAppEntities dbContext) : base(dbContext) { }

        //public IEnumerable<listItem> GetAcademicyearforSelect()
        //{
        //    List<listItem> lst = new List<listItem>();
        //    lst.Add(new listItem() { Value = -1, Description = "(None)" });
        //    lst.AddRange(
        //        from xx in this.context.Sessions
        //        select new listItem() { Value = xx.SessionId, Description = xx.SessionName }
        //        );
        //    return lst;
        //}

        
        //public void AddNewAcademicyear(Session obj) 
        //{
        //    this.Insert(obj);
        //    return;
        //}
        //public void UpdateAcademicyear(Session obj)
        //{
        //    Session c = this.GetByID(obj.SessionId);
        //    c.SessionName = obj.SessionName;
        //    this.Update(c);
        //    return;
        //}
        //public void DeleteAcademicyear(Session obj)
        //{
        //    this.Delete(obj);
        //    return;
        //}
        //public Session GetCurrentSession()
        //{
        //    //DateTime currDT=DateTime.Now;
        //    //Session s= this.Get(). .Where(x => x.StartDate.Value >= currDT && x.EndDate.Value <= currDT).FirstOrDefault();
        //    return this.GetByID(2);
        //}


       

        //public StudentLogin IsStudentValid(ModelStudentLogin objmodel)
        //{

        //    StudentLogin objLog = new StudentLogin();

        //    objLog = this.context.StudentLogins.Where(i => i.StudentUserName == objmodel.UserName && i.Password == objmodel.Password).FirstOrDefault();

        //    return objLog;
        //}


      

    




    }

  


}
