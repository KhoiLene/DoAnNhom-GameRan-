using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAnNhom_GameRan_
{
    public class Database
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        // ================= DTO =================
        public class ScoreDTO
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string LevelName { get; set; }
            public int Score { get; set; }
        }

        // ================= SAVE SCORE =================
        public void SaveScore(int userId, string levelName, int score)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new Exception("User không tồn tại");

            HighScores2 newScore = new HighScores2
            {
                UserId = userId,
                LevelName = levelName,
                Score = score
            };

            db.HighScores2s.InsertOnSubmit(newScore);
            db.SubmitChanges();

            var serverHigh = db.HighScores
                               .FirstOrDefault(h => h.LevelName == levelName);

            if (serverHigh == null)
            {
                HighScore hs = new HighScore
                {
                    LevelName = levelName,
                    Score = score
                };

                db.HighScores.InsertOnSubmit(hs);
            }
            else
            {
                if (score > serverHigh.Score)
                {
                    serverHigh.Score = score;
                }
            }

            db.SubmitChanges();
        }

        // ================= GET SCORE =================
        public int GetUserHighScore(int userId, string levelName)
        {
            var score = db.HighScores2s
                          .Where(s => s.UserId == userId && s.LevelName == levelName)
                          .Max(s => (int?)s.Score);

            return score ?? 0;
        }

        public int GetServerHighScore(string levelName)
        {
            var score = db.HighScores
                          .Where(s => s.LevelName == levelName)
                          .Select(s => (int?)s.Score)
                          .FirstOrDefault();

            return score ?? 0;
        }

        // ================= LOGIN =================
        public int LoginUser(string Email, string username, string password)
        {
            var user = db.Users
                .FirstOrDefault(u =>
                    (u.Username == username || u.Email == Email) &&
                    u.Password == password
                );

            return user != null ? user.Id : -1;
        }

        // ================= REGISTER =================
        public int RegisterUser(string Email, string username, string password)
        {
            var exists = db.Users.Any(u => u.Username == username);

            if (exists) return -1;

            User newUser = new User
            {
                Email = Email,
                Username = username,
                Password = password
            };

            db.Users.InsertOnSubmit(newUser);
            db.SubmitChanges();

            return newUser.Id;
        }

        public bool CheckEmailExists(string email)
        {
            return db.Users.Any(u => u.Email == email);
        }

        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }

        public void UpdatePassword(string email, string newUsername, string newPassword)
        {
            var user = db.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                user.Username = newUsername;
                user.Password = newPassword;
                db.SubmitChanges();
            }
        }

        // ================= GET DATA FOR EXCEL =================
        public List<ScoreDTO> GetAllScores()
        {
            return db.HighScores2s
                     .Select(s => new ScoreDTO
                     {
                         UserId = s.UserId,
                         LevelName = s.LevelName,
                         Score = s.Score
                     })
                     .ToList();
        }

        public List<ScoreDTO> GetScoresByUser(int userId)
        {
            return db.HighScores2s
                     .Where(s => s.UserId == userId)
                     .Select(s => new ScoreDTO
                     {
                         UserId = s.UserId,
                         LevelName = s.LevelName,
                         Score = s.Score
                     })
                     .ToList();
        }

        public List<ScoreDTO> GetTopScoresByLevel(string levelName)
        {
            var query = db.HighScores2s
                .Where(s => s.LevelName == levelName)
                .GroupBy(s => s.UserId)
                .Select(g => new
                {
                    UserId = g.Key,
                    MaxScore = g.Max(x => x.Score)
                })
                .GroupJoin(db.Users,
                    s => s.UserId,
                    u => u.Id,
                    (s, users) => new { s, users })
                .SelectMany(
                    x => x.users.DefaultIfEmpty(), 
                    (x, u) => new ScoreDTO
                    {
                        UserId = x.s.UserId,
                        Username = u != null ? u.Username : "Guest", 
                        LevelName = levelName,
                        Score = x.s.MaxScore
                    })
                .OrderByDescending(x => x.Score);

            return query.ToList();
        }

        public User GetUserByUsername(string username)
        {
            return db.Users.FirstOrDefault(u => u.Username == username);
        }

        public bool IsUsernameExists(string username)
        {
            return db.Users.Any(u => u.Username == username);
        }
    }
}