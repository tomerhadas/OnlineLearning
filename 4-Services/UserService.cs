using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform;

public class UserService
{
    private readonly ApplicationContext _db;

    public UserService(ApplicationContext db)
    {
        _db = db;
    }


    public List<User> GetAllUsers()
    {
        return _db.Users.ToList();
    }
}
