using System;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using NUnit.Framework;
using TestStack.BDDfy;

namespace $rootnamespace$
{   
    [TestFixture]
    [Story(AsA = "$StoryAs$",
        IWant = "$StoryIWant$",
        SoThat = "$StorySoThat$")]
	public class $safeitemrootname$
	{
        [SetUp]
        public void SetUp()
	    {
	        
	    }

        private void $MainArrangement$()
	    {
	        
	    }

        private void $MainAct$()
	    {
	        
	    }
    
        private void $MainAssertion$()
	    {
	        
	    }

        [Test]
        public void $MainScenarioMethod$()
	    {
	        this.Given(_ => $MainArrangement$())
                .When(_ => $MainAct$())
                .Then(_ => $MainAssertion$())
                .BDDfy("$ScenarioTitle$");
	    }
	}
}
