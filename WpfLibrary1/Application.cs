using System;
using WpfLibrary1;


namespace WpfLibrary1
{
    public class Application
    {
        private static Application application;
        private static Application GetApplication()
        {
            return application;
        }
        private static void CreateTaskList(string name)
        {
            
        }
        public class TaskList
        {
            private static string name;
            private static TaskList tasks;

        }
        public class Task
        {
            private static string title;
            private static DateTime due;
            private static bool done;
        }
    }
}
