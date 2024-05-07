namespace AirTrafficControlLibrary
{
    public static class Print
    {
        public static void ShowSuccess(string message) =>
       ShowMessage(message);

        public static void ShowError(string message) =>
            ShowMessage(message);

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }

}
