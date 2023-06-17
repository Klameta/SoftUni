namespace Common
{
    public static class EntityValidation
    {
        public static class Task
        {
            public const int TitleMinLenght = 5;
            public const int TitleMaxLenght = 70;

            public const int DescriptionMinLenght = 10;
            public const int DescriptionMaxLenght = 1_000;
        }

        public static class Board
        {
            public const int NameMinLenght = 3;
            public const int NameMaxLenght = 30;
        }
    }
}