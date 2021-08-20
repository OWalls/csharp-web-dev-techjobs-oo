using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        

        Job emptyJob1;
        Job emptyJob2;
        Job job3;
        Job job4;
        Location desert;
        
        [TestInitialize]
        public void CreateJobObjects()
        {
            emptyJob1 = new Job();
            emptyJob2 = new Job();
            desert = new Location("desert");
            job3 = new Job("Product tester", new Employer("ACME"), desert, new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), desert, new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(emptyJob1.Id == emptyJob2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.IsTrue(job3.EmployerLocation.Value == "desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
    }
}
