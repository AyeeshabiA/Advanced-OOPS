using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseEnrollment
{
    public class CourseDetails
    {
        /*
•	CourseID (CS101)
•	CourseName
•	TrainerName
•	CourseDuration
•	SeatsAvailabe
*/      
        private int s_courseID=100;
        public string CourseID{get;}
        public string CourseName{get; set;}
        public string TrainerName{get; set;}
        public int CourseDuration{get; set;}
        public int SeatsAvailabe{get; set;}

        public CourseDetails(string courseName,string trainerName,int courseDuration,int seatsAvailable)
        {
            s_courseID++;
            CourseID="CS"+s_courseID;
            CourseName=courseName;
            TrainerName=trainerName;
            CourseDuration=courseDuration;
            SeatsAvailabe=seatsAvailable;
        }
    }
}