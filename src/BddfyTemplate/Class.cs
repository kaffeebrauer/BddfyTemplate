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
	public class $safeitemrootname$ $ImplementedClass$
	{
        [SetUp]
        public void SetUp()
	    {
	        
	    }

        $MainArrangementSection$
	    
        $MainActSection$
	    
        $MainAssertionSection$
	   
        [Test]
        public void $MainScenarioMethod$()
	    {
	        $MainArrangementStatements$
                .When(_ => $MainAct$())
                $MainAssertionStatements$
                .BDDfy("$ScenarioTitle$");
	    }
	}
}
