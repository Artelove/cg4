﻿namespace CG4.Impl.Dapper.Poco.Expressions
{
    public abstract class ExprFunction : Expr
    {
        public abstract string Name { get; }

        public string ResultName { get; set; }

        public List<Expr> Parametrs { get; } = new();

        public override void Accept(IExprVisitor visitor) => visitor.VisitFunction(this);
    }
}
