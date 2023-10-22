using MultipleDbContextPractice.Models;

namespace MultipleDbContextPractice.Dto
{
    public record struct UserResponseDto(int Id, string Name, List<Character> Characters);


}
