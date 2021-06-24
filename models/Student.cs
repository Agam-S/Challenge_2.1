namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Student : Person {
        public int StudentNo { get; set; }
        public int FirstRegistrationYear { get; set; }

        public Student(string firstName, string surname, int yearOfBirth, int monthOfBirth, int dateOfBirth, int studentNo, int firstRegistrationYear) : base(firstName, surname, yearOfBirth, monthOfBirth, dateOfBirth)
        {
            this.StudentNo = studentNo;
            this.FirstRegistrationYear = firstRegistrationYear;
        }

        // public string GetFullName() {
        //     //TODO:  return FirstName and Surname with a space in between
        //     // return $"{Person.FirstName} {Person.Surname}";
        // }

      

        
        

    }
}