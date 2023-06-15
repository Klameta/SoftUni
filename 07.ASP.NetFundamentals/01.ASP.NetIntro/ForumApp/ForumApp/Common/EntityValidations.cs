namespace ForumApp.Common
{
    public static class EntityValidations
    {
        public static class Post
        {
            public const int TitleMinLength = 10;
            public const int TitleMaxLength = 60;

            public const int ContentMinLenght = 30;
            public const int ContentMaxLenght = 1500;
        }
    }
}
