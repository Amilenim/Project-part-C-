﻿namespace Project
{
    public abstract class IPerson
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
    }
}
