﻿namespace RepoTest.Classes
{
    public abstract class Media
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public abstract void Display();

    }

}