using DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq;
using Npgsql;

namespace DataAccessPostgreSqlProvider
{
    public class DataAccessPostgreSqlProvider : IDataAccessProvider
    {
        private readonly DomainModelPostgreSqlContext _context;
        private readonly ILogger _logger;

        public DataAccessPostgreSqlProvider(DomainModelPostgreSqlContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessPostgreSqlProvider");
        }

        public async Task<List<Pessoa>> GetListaPessoaAsync()
        {
            //var ola = await _context.Pessoas.ToListAsync();
            //var ola = await _context.Database.GetDbConnection().QueryAsync<Pessoa>(@"select * from public.""PESSOA""");
            var ola = await _context.Database.GetDbConnection().QueryAsync<Pessoa>("select * from pessoa");
            return ola.ToList();
            //List<Pessoa> ola = new List<Pessoa>();
            //using (var conn = new NpgsqlConnection(@"User ID=postgres;Password=dress.1986;Host=localhost;Port=5432;Database=TESTEBRUNO;Pooling=true;"))
            //{
            //    conn.Open();
            //    using (var cmd = new NpgsqlCommand(@"select * from public.""PESSOA""", conn))
            //    {
            //        using (var reader = cmd.ExecuteReader())
            //            while (reader.Read())
            //                Console.WriteLine(reader.GetString(0));
            //    }
            //}
            //return ola;
        }

        public async Task<Pessoa> GetPessoaId(int id)
        {
            return await _context.Pessoas.FirstAsync(p => p.Pessoa_id == id);
        }
    }
}
