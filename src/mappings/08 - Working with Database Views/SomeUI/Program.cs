using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;
using System.Linq;

namespace SomeUI
{
    internal class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        private static void Main(string[] args)
        {
            GetStats();
            Filter();
            Project();
        }
        private static void GetStats()
        {
            var stats = _context.SamuraiBattleStats.AsNoTracking().ToList();
        }
        private static void Filter()
        {
            var stats = _context.SamuraiBattleStats.Where(s => s.SamuraiId == 2).AsNoTracking().ToList();
        }
        private static void Project()
        {
            var stats = _context.SamuraiBattleStats.AsNoTracking().Select(s => new { s.Name, s.NumberOfBattles }).ToList();
        }
    }
}