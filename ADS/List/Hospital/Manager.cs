using ADSApi.DataStructures.Methods;
using ADSApi.List.Hospital.Exceptions;
using ADSApi.List.Util;
using System;

namespace ADSApi.List
{
    public class Manager
    {
        public const string ITCType = "ITC";
        public const string ITUType = "ITU";
        public const string NurseryType = "Nursery";
        public const string BedType = "Bed";

        // Translated from CTI - Intensive Therapy Center
        private static Queue<Person> ITC;

        // Translated from UTI - Intensive Therapy Unity
        private static Queue<Person> ITU;

        // Translated from enfermaria
        private static Queue<Person> Nursery;

        // Translated from leito
        private static Queue<Person> Bed;

        public static void AddPerson(Person person, string targetBed)
        {
            switch (targetBed)
            {
                case ITCType:
                    ITC.Insert(person);
                    break;
                case ITUType:
                    ITU.Insert(person);
                    break;
                case NurseryType:
                    Nursery.Insert(person);
                    break;
                case BedType:
                    Bed.Insert(person);
                    break;
                default: 
                    throw new InvalidLocation(targetBed);
            }
        }
            
        public static Person RemovePerson(Person person)
        {
            Person p;

            if ((p = (Person)Bed.Remove(person)) != null) return p;
            else if ((p = (Person)Nursery.Remove(person)) != null) return p;
            else if ((p = (Person)ITU.Remove(person)) != null) return p;
            else if ((p = (Person)ITC.Remove(person)) != null) return p;
            else throw new PersonNotExists(person);

        }

        public static void RealocatePerson(Person person, string targetBed)
        {
            Person p = RemovePerson(person);
            AddPerson(p, targetBed);
        }

        public static int AmountOfPeople()
        {
            return ITU.Size() + ITC.Size() + Nursery.Size() + Bed.Size();
        }

        public static bool IsEmpty()
        {
            return AmountOfPeople() == 0;
        }

        /// <summary>
        /// While true aval persons (make it better or worser, can be from 0 - good to 5 - UTI)
        /// right after aval, realocate or just remove. 
        /// 
        /// Some times insert a person. 
        /// </summary>

        public static void Run()
        {
            Random r = new Random();
            while (!IsEmpty())
            {
                if(r.Next(0,1) == 1)
                {
                    
                }
            }
        }
    }
}
