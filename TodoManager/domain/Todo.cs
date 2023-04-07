namespace TodoManager.Properties.domain
{
    public class Todo
    {
        public int Id { get; init; }
        public string Title { get; set; }

        ///<summary>
        ///День, на который запланирована Todo
        ///</summary>

        public DateTime PlannedDay {  get; init; }

        public Todo(int id, string title, DateTime plannedDay)
        {
            Id = id;
            Title = title;
            PlannedDay = plannedDay;
        }

        public Todo(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
