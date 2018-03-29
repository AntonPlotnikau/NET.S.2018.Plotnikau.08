using System;

namespace BankOperations
{
    /// <summary>
    /// Represents work with bank account
    /// </summary>
    public class BankAccount
    {
        #region Fields

        /// <summary>
        /// Person data
        /// </summary>
        private Person person;

        /// <summary>
        /// The account type
        /// </summary>
        private AccountType accountType;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="person">Person data.</param>
        /// <param name="accountType">Type of the account.</param>
        /// <exception cref="System.ArgumentNullException">accountType is null</exception>
        public BankAccount(Person person, AccountType accountType)
        {
            this.Person = person;
            this.Id = Guid.NewGuid();
            this.accountType = accountType ?? throw new ArgumentNullException(nameof(accountType));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the person data.
        /// </summary>
        /// <value>
        /// The person data.
        /// </value>
        /// <exception cref="System.ArgumentNullException">value name or last name is null</exception>
        public Person Person
        {
            get
            {
                return this.person;
            }

            set
            {
                if (value.Name != null && value.Lastname != null)
                {
                    this.person = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the sum.
        /// </summary>
        /// <value>
        /// The sum.
        /// </value>
        public decimal Sum { get; private set; }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Adds the specified sum.
        /// </summary>
        /// <param name="sum">The sum that we add.</param>
        /// <exception cref="System.ArgumentException">sum is less than or equal to zero</exception>
        public virtual void Add(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException(nameof(sum));
            }

            this.Sum += sum;
            this.accountType.AddBonus();
        }

        /// <summary>
        /// Withdraws the specified sum.
        /// </summary>
        /// <param name="sum">The sum that we withdraw.</param>
        /// <exception cref="System.ArgumentException">The sum that we withdraw more than our balance</exception>
        public virtual void Withdraw(decimal sum)
        {
            if (sum > this.Sum)  
            {
                throw new ArgumentException(nameof(sum));
            }

            this.Sum -= sum;
            this.accountType.WithdrawBonus();
        }

        #endregion
    }
}
