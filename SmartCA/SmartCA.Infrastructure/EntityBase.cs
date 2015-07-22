using System;

namespace SmartCA.Infrastructure.DomainBase
{
    public abstract class EntityBase
    {
        private object key;

        /// <summary>
        /// Default Constructor
        /// </summary>
        protected EntityBase() : this(null)
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
    }
}
