﻿namespace hospital_project_interface_v2
{
    public class Administrative : Person
    {
        public Administrative(string identification, string name, string lastName, int age)
                            : base(identification, name, lastName, age)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Tipo de persona: Personal Administrativo"; 
        }
    }
}
