using System;
using EasySpecificationValidator.Specification;

namespace EasySpecificationValidator.Tests.Samples.Specifications.Person
{
    public class FirstNameCannotBeGreaterThanTwentyFive : GenericSpecification<Entities.Person>
    {
        #region Overrides of GenericSpecification<Person>

        public override Func<Entities.Person, bool> Rule => a => (a.FirstName.Length <= 25);

        #endregion
    }
}