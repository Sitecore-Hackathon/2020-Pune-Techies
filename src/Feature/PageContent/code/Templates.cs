namespace Sitecore.Feature.PageContent
{
    using Sitecore.Data;



    public struct Templates
    {
        public struct HasPageContent
        {
            public static readonly ID ID = new ID("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}");



            public struct Fields
            {
                public static readonly ID Title = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string Title_FieldName = "Title";
                public static readonly ID Summary = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string Summary_FieldName = "Summary";
                public static readonly ID Body = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string Body_FieldName = "Body";
                public static readonly ID Image = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public static readonly ID RichText = new ID("{714D24D5-1407-4BB1-AF57-683A9EDCEEFB}");
            }
        }



        public struct ModuleDetails
        {
            public static readonly ID ID = new ID("{C5F352D1-D5CC-4ACA-9D78-89DD09CBBA73}");



            public struct Fields
            {
                public static readonly ID ModuleVideo = new ID("{853EB27A-2C7F-469B-86B8-3F7846061589}");
                public static readonly ID GitHubLink = new ID("{EE9755A1-834E-47CE-B762-2957CDDC22DA}");
            }
        }



        public struct HasWinner
        {
            public static readonly ID ID = new ID("{41C621A8-752F-44F5-B395-8D01092DAE51}");



            public struct Fields
            {
                public static readonly ID WinnerList = new ID("{168DD13F-978D-43DE-A2C6-30FD9944C64F}");
            }
        }



        public struct HasJudges
        {
            public static readonly ID ID = new ID("{41C621A8-752F-44F5-B395-8D01092DAE51}");



            public struct Fields
            {
                public static readonly ID JudgesList = new ID("{7782A31A-5A6C-4C58-BB99-DFDAF99DED36}");
            }
        }



        public struct NotShowInList
        {
            public static readonly ID ID = new ID("{81B82998-B13A-4BA0-A709-34A9C5BAFC5C}");




        }
    }



}