namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Person {

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }
        public int MonthOfBirth { get; set; }
        public int DateOfBirth { get; set; }

        public Person (string firstName, string surname, int yearOfBirth, int monthOfBirth, int dateOfBirth) {
            this.FirstName = firstName;
            this.Surname = surname;
            this.YearOfBirth = yearOfBirth;
            this.MonthOfBirth = monthOfBirth;
            this.DateOfBirth = dateOfBirth;

        }

    }
}