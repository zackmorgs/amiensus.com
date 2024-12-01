using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Services {
    public class MemberService {
        public MemberService(AmiensusDb context) {
            _context = context;
        }
        private AmiensusDb _context { get; set; }

        public async Task AddMember(Member member) {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public async Task DeleteMember(int id) {
            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member);
            _context.SaveChanges();
        }

        public async Task<List<Member>> GetAllMembers() {
            var members = await _context.Members.ToListAsync();
            return members;
        }

    }

}