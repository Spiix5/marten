// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Reading.Linq;
using Marten.Internal.CompiledQueries;
using Marten.Linq;
using Marten.Linq.QueryHandlers;
using System;

namespace Marten.Generated.CompiledQueries
{
    // START: NoneCompiledQueryTargetCompiledQuery9758203
    public class NoneCompiledQueryTargetCompiledQuery9758203 : Marten.Internal.CompiledQueries.ClonedCompiledQuery<DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.QueryTarget, DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.CompiledQueryTarget>
    {
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _inner;
        private readonly DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.CompiledQueryTarget _query;
        private readonly Marten.Linq.QueryStatistics _statistics;
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;

        public NoneCompiledQueryTargetCompiledQuery9758203(Marten.Linq.QueryHandlers.IMaybeStatefulHandler inner, DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.CompiledQueryTarget query, Marten.Linq.QueryStatistics statistics, Marten.Internal.CompiledQueries.HardCodedParameters hardcoded) : base(inner, query, statistics, hardcoded)
        {
            _inner = inner;
            _query = query;
            _statistics = statistics;
            _hardcoded = hardcoded;
        }



        public override void ConfigureCommand(Weasel.Postgresql.CommandBuilder builder, Marten.Internal.IMartenSession session)
        {
            var parameters = builder.AppendWithParameters(@"select d.id, d.data from public.mt_doc_simpleequalsparsertests_querytarget as d where (CAST(d.data ->> 'IntProp' as integer) = ? and d.id = ?) LIMIT ?");

            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[1].Value = _query.IdProp;

            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            parameters[0].Value = _query.IntProp;

            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            parameters[2].Value = _query.IntProp;
        }

    }

    // END: NoneCompiledQueryTargetCompiledQuery9758203
    
    
    // START: NoneCompiledQueryTargetCompiledQuerySource9758203
    public class NoneCompiledQueryTargetCompiledQuerySource9758203 : Marten.Internal.CompiledQueries.CompiledQuerySource<DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.QueryTarget, DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.CompiledQueryTarget>
    {
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _maybeStatefulHandler;

        public NoneCompiledQueryTargetCompiledQuerySource9758203(Marten.Internal.CompiledQueries.HardCodedParameters hardcoded, Marten.Linq.QueryHandlers.IMaybeStatefulHandler maybeStatefulHandler)
        {
            _hardcoded = hardcoded;
            _maybeStatefulHandler = maybeStatefulHandler;
        }



        public override Marten.Linq.QueryHandlers.IQueryHandler<DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.QueryTarget> BuildHandler(DocumentDbTests.Reading.Linq.SimpleEqualsParserTests.CompiledQueryTarget query, Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.CompiledQueries.NoneCompiledQueryTargetCompiledQuery9758203(_maybeStatefulHandler, query, null, _hardcoded);
        }

    }

    // END: NoneCompiledQueryTargetCompiledQuerySource9758203
    
    
}
