using System.Collections.Generic;

namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Course {
        public string Name { get; set; }
        public int CourseNo { get; set; }
        public List<Student> Enrolments { get; set; }

        public Course (string name, int courseNo) {
            this.Name = name;
            this.CourseNo = courseNo;
            this.Enrolments = new List<Student>();

        }
        

        public string GetCourseDetails() {
            return $"{this.CourseNo}: {this.Name}";
        }
        

        


       
    }
}