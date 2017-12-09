﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum TypeOfAlert
    {
        Disability = 1
    }
    public class PatientAlert
    {

        public int Id { get; set; }
        public TypeOfAlert AlertType { get; set; }

        //Type Of Disability
        public bool PsychosocialDisability { get; set; }
        public bool DisabilityDutToChronicIllness { get; set; }
        public bool LearningDisability { get; set; }
        public bool MentalIntellectual { get; set; }
        public bool VisualDisability { get; set; }
        public bool OrthopedicMusculoskeletalDisability { get; set; }
        public bool HearingDisability { get; set; }
        public bool SpeechImpairment { get; set; }
        public bool MultipleDisabilities { get; set; }

        public string Description { get; set; }



    }
}
