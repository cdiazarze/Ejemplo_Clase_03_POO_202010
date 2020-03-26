using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        //DEFAULT VALUES: Todos los valores por defecto. Están definidos como protected porque se utilizarán en las clases hijas
        protected const int DEFAULT_LEVEL = 1;
        protected const int DEFAULT_HEALTHPOINT = 100;
        protected const string DEFAULT_NAME = "Bob";

        //Atributos, siempre private. Otra cosa importante es fijarse en que separo int, string y clases creadas, solo para orden
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Armor bodyArmor;
        private Weapon weapon;

        // Propiedades: Esto permite acceder desde afuera a los atributos. Puedo agregar lógica, por ejemplo, no quiero que los puntos de vida sean menores a 0 o mayores que 120.
        // fijense en las propiedades HealthPoints, Level, Name, Faction
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 120.");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "The faction should be either Melee or Spellcaster");
                }
            }
        }

        //Cadena de constructores dentro de la misma clase: Notar que este constructor vacío llama a this.(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINT), esto quiere decir que si se crea un objeto con el constructor sin párametros, es decir,
        // Character charac = new Character(), lo que hará el programa por detrás será llamar al siguiente constructor de está clase, el cual recibirá los tres parámetros por defecto.
        public Character()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINT)
        {
        }

        public Character(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
        }


    }
}
