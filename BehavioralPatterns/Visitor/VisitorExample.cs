using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Visitor
{
    class VisitorExample
    {
        // Dependency injecting a visitor into a method to extend bechavior Base.accept(visitor) { visitor.visit(this); } and visitor.visit(base) { base.method + other stuff }
        //extends method without changing base class except visitor property
    }
}
