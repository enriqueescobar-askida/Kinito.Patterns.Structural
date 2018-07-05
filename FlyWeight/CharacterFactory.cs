namespace FlyWeight
{
    using System.Collections.Generic;

    /// <summary>
    /// The character factory.
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// The characters.
        /// </summary>
        private readonly Dictionary<char, AbstractCharacter> characters =
            new Dictionary<char, AbstractCharacter>();

        /// <summary>
        /// The get character.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="AbstractCharacter"/>.
        /// </returns>
        public AbstractCharacter GetCharacter(char key)
        {
            // Uses "lazy initialization"
            AbstractCharacter character = null;
            if (this.characters.ContainsKey(key))
                character = this.characters[key];
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                this.characters.Add(key, character);
            }

            return character;
        }
    }
}