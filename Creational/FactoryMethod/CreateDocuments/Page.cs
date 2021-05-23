using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDocuments
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class SkillsPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class EducationPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ExperiencePage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class IntroductionPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ResultsPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConclusionPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class SummaryPage : Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class BibliographyPage : Page { }
}
