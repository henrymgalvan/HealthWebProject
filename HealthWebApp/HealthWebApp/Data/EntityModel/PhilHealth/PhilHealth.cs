﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.PhilHealth
{
    public enum StatusType
    {
        Member = 1, NonMember = 2, Dependent = 3
    }

    public enum TypeOfMembership
    {
        Sponsored = 1, IndividuallyPayingProgram = 2, Employed = 3, Lifetime = 4
    }

    public enum TypeOfSponsorship
    {
        NHTS = 1, LGU = 2, NGA = 3, Private =4
    }

    public enum IPP
    {
        OrganizedGroup = 1, OFW = 2
    }

    public enum EmployerType
    {
        Government = 1, Private = 2
    }


    public class PhilHealth
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public StatusType StatusType { get; set; }
        public TypeOfMembership Category { get; set; }
        //Sponsored
        public TypeOfSponsorship Sponsored { get; set; }
        //Individually Paying Program (IPP)
        public IPP Individual { get; set; }
        //Employed
        public EmployerType EmployerType { get; set; }
        public bool Lifetime { get; set; }

        public DateTime DateAssigned { get; set; }


    }
}
