using Ardalis.Specification;
using EM24.Core.Entities;

namespace EM24.Core.Specifications;

public sealed class GetGuessesByPlayerIdSpec : Specification<PlayerGuess>
{
    public GetGuessesByPlayerIdSpec(int playerId)
    {
        Query.Where(x => x.PlayerId == playerId);
    }
}