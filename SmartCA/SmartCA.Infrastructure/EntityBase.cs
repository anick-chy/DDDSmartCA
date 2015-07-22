using System;

namespace SmartCA.Infrastructure.DomainBase
{
    public abstract class EntityBase
    {
        private object key;

        /// <summary>
        /// Default Constructor
        /// </summary>
        protected EntityBase()
            : this(null)
        {

        }

        /// <summary>
        /// Overloaded constructor.
        /// </summary>
        /// <param name="key">An <see cref="System.Object" /> that
        /// represents the primary identifier value for the
        /// class.</param>
        protected EntityBase(object key)
        {
            this.key = key;
        }

        /// <summary>
        /// An <see cref="System.Object" /> that
        /// represents the primary identifier value for the
        /// class.
        /// </summary>
        public object Key
        {
            get { return this.key; }
        }

        #region equality test

        /// <summary>
        /// Determines whether the specified entity is equal to the
        /// current instance.
        /// </summary>
        /// <param name="entity">An <see cref="System.Object" /> that
        /// will be compared to the current instance.</param>
        /// <returns>> True if the passed in entity is equal to the
        /// current instance.</returns>
        public override bool Equals(object entity)
        {
            if (entity == null || !(entity is EntityBase))
            {
                return false;
            }
            return base.Equals(entity);
        }

        /// <summary>
        /// Operator overload for determining equality
        /// </summary>
        /// <param name="entity1">The first instance of an <see cref="EntityBase"/>.</param>
        /// <param name="entity2">The second instance of an <see cref="EntityBase"/>.</param>
        /// <returns>True if equal</returns>
        public static bool operator ==(EntityBase entity1, EntityBase entity2)
        {
            //check for both null
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            //check for either of them equals to null
            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1.Key != entity2.Key)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Operator overload for determining inequality
        /// </summary>
        /// <param name="entity1">The first instance of an <see cref="EntityBase"/>.</param>
        /// <param name="entity2">The second instance of an <see cref="EntityBase"/>.</param>
        /// <returns></returns>
        public static bool operator !=(EntityBase entity1, EntityBase entity2)
        {
            return (!(entity1 == entity2));
        }

        /// <summary>
        /// Serves as a hash function for this type.
        /// </summary>
        /// <returns>A hash code for the current Key property</returns>
        public override int GetHashCode()
        {
            return this.key.GetHashCode();
        }

        #endregion
    }
}
