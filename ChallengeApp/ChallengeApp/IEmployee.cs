namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        
        int Age { get; }
        char Sex { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
