namespace Application.Requests;

public record RegisterRequest(string Email, 
                              string Username,
                              string Password, 
                              string RepeatPassword);