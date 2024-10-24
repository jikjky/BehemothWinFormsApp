using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BehemothWinFormsApp.Class
{
    public enum CharacterClass
    {
        Dealer,
        Supporter
    }

    public enum PartyCombinations
    {
        DDDD = 0,
        DDDS = 1,
        DDSS = 2,
        DSSS = 3,
        SDDD = 10,
        SDDS = 11,
        SDSS = 12,
        SSSS = 13,
    }

    public class Player
    {
        public List<string> OrderMessages { get; set; } = new List<string>();
        public int UsedSupoterCount { get; set; } = 0;
        public int SupoterCount
        {
            get
            {
                int result = 0;
                if (StrongCharacter == CharacterClass.Supporter)
                {
                    result++;
                }

                foreach (CharacterClass characterClass in WeekCharacter)
                {
                    if (characterClass == CharacterClass.Supporter)
                    {
                        result++;
                    }
                }


                return result;
            }
        }
        public CharacterClass StrongCharacter { get; set; }
        public List<CharacterClass> WeekCharacter { get; set; } = new List<CharacterClass>();

        public PartyCombinations GetPlayerPartyCombinations()
        {
            int offset = 0;
            if (WeekCharacter.Where(x => x == CharacterClass.Dealer).Count() == 3)
            {
                offset = 0;
            }
            if (WeekCharacter.Where(x => x == CharacterClass.Dealer).Count() == 2)
            {
                offset = 1;
            }
            if (WeekCharacter.Where(x => x == CharacterClass.Dealer).Count() == 1)
            {
                offset = 2;
            }
            if (WeekCharacter.Where(x => x == CharacterClass.Dealer).Count() == 0)
            {
                offset = 3;
            }
            return StrongCharacter == CharacterClass.Dealer ? PartyCombinations.DDDD + offset : PartyCombinations.SDDD + offset;
        }
    }
    public class Party
    {
        public int CurrentSupoter { get; set; } = 0;
        public int MaxSupoter { get; set; } = 4;
        public int CurrnetCombinations { get; set; } = 0;
        public int MaxCombinations { get; set; } = 16;

        public bool StrongSupoter { get; set; } = false;
        public List<Player> Players { get; set; } = new List<Player>();

        public void Add(Player player)
        {
            if (player.StrongCharacter == CharacterClass.Supporter)
            {
                StrongSupoter = true;
            }
            CurrentSupoter += player.SupoterCount;
            CurrnetCombinations += 4;
            Players.Add(player);
        }

        public void Add(PartyCombinations partyCombinations)
        {
            switch (partyCombinations)
            {
                case PartyCombinations.DDDD:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Dealer,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Dealer, CharacterClass.Dealer]
                    });
                    break;
                case PartyCombinations.DDDS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Dealer,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Dealer, CharacterClass.Supporter]
                    });
                    break;
                case PartyCombinations.DDSS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Dealer,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Supporter, CharacterClass.Supporter]
                    });
                    break;
                case PartyCombinations.DSSS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Dealer,
                        WeekCharacter = [CharacterClass.Supporter, CharacterClass.Supporter, CharacterClass.Supporter]
                    });
                    break;
                case PartyCombinations.SDDD:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Supporter,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Dealer, CharacterClass.Dealer]
                    });
                    break;
                case PartyCombinations.SDDS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Supporter,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Dealer, CharacterClass.Supporter]
                    });
                    break;
                case PartyCombinations.SDSS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Supporter,
                        WeekCharacter = [CharacterClass.Dealer, CharacterClass.Supporter, CharacterClass.Supporter]
                    });
                    break;
                case PartyCombinations.SSSS:
                    Add(new Player()
                    {
                        StrongCharacter = CharacterClass.Supporter,
                        WeekCharacter = [CharacterClass.Supporter, CharacterClass.Supporter, CharacterClass.Supporter]
                    });
                    break;
                default:
                    break;
            }
        }

        public void Remove(Player player)
        {
            if (player.StrongCharacter == CharacterClass.Supporter)
            {
                StrongSupoter = false;
            }
            CurrentSupoter -= player.SupoterCount;
            CurrnetCombinations -= 4;
            Players.Remove(player);
        }

        public bool OKPartyCombinations(PartyCombinations partyCombinations)
        {
            var needSupoter = MaxSupoter - CurrentSupoter;
            var needCombinations = MaxCombinations - CurrnetCombinations;
            int supoter = 0;
            switch (partyCombinations)
            {
                case PartyCombinations.DDDD:
                    supoter = 0;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needCombinations != 0;

                case PartyCombinations.DDDS:
                    supoter = 1;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.DDSS:
                    supoter = 2;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.DSSS:
                    supoter = 3;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.SDDD:
                    if (StrongSupoter == true)
                    {
                        return false;
                    }
                    supoter = 1;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.SDDS:
                    if (StrongSupoter == true)
                    {
                        return false;
                    }
                    supoter = 2;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.SDSS:
                    if (StrongSupoter == true)
                    {
                        return false;
                    }
                    supoter = 3;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;

                case PartyCombinations.SSSS:
                    if (StrongSupoter == true)
                    {
                        return false;
                    }
                    supoter = 4;
                    if (needCombinations - 4 == 0)
                    {
                        return needSupoter == supoter;
                    }
                    return needSupoter >= supoter;
            }
            return false;
        }

        public int DepartureOrder { get; set; } = 0;

        public string Make()
        {
            if (CurrnetCombinations == MaxCombinations)
            {
                foreach (var item in Players)
                {
                    item.OrderMessages = ["", "", "", ""];
                    item.UsedSupoterCount = 0;
                }
                var stroingSupoterFindAll = Players.FindAll(x => x.StrongCharacter == CharacterClass.Supporter);
                if (stroingSupoterFindAll.Count() == 1)
                {
                    var stroingSupoter = stroingSupoterFindAll[0];
                    stroingSupoter.OrderMessages[DepartureOrder] = "(ㅍ)";
                    stroingSupoter.UsedSupoterCount++;
                    foreach (var item in Players)
                    {
                        if (!item.Equals(stroingSupoter))
                        {
                            item.OrderMessages[DepartureOrder] = "(ㄷ)";
                        }
                    }
                }
                else
                {
                    var weekSupoterFindAll = Players.FindAll(x => x.SupoterCount != 0 && (x.SupoterCount > x.UsedSupoterCount));
                    var weekSupoter = weekSupoterFindAll[0];
                    weekSupoter.OrderMessages[DepartureOrder] = "ㅍ";
                    weekSupoter.UsedSupoterCount++;
                    if (DepartureOrder == 0)
                    {
                        weekSupoter.OrderMessages[DepartureOrder + 1] = "(ㄷ)";
                    }
                    else
                    {
                        weekSupoter.OrderMessages[DepartureOrder - 1] = "(ㄷ)";
                    }
                    weekSupoter.UsedSupoterCount++;
                    foreach (var item in Players)
                    {
                        if (!item.Equals(weekSupoter))
                        {
                            item.OrderMessages[DepartureOrder] = "(ㄷ)";
                        }
                    }
                }
                for (var i = 0; i < 3; i++)
                {
                    int index = i;
                    if (DepartureOrder <= i)
                    {
                        index++;
                    }
                    var weekSupoterFindAll = Players.FindAll(x => x.SupoterCount != 0 && (x.SupoterCount > x.UsedSupoterCount));
                    var weekSupoter = weekSupoterFindAll[0];
                    weekSupoter.OrderMessages[index] = "ㅍ";
                    weekSupoter.UsedSupoterCount++;
                    foreach (var item in Players)
                    {
                        if (!item.Equals(weekSupoter))
                        {
                            if (string.IsNullOrEmpty(item.OrderMessages[index]))
                            {
                                item.OrderMessages[index] = "ㄷ";
                            }
                        }
                    }
                }
                string result = string.Empty;
                int playerIndex = 1;
                foreach (var item in Players)
                {
                    result += $"  {DepartureOrder + 1}-{playerIndex}  ";
                    int orderIndex = 1;
                    foreach (var message in item.OrderMessages)
                    {
                        result += message;
                        orderIndex++;
                    }
                    playerIndex++;
                }
                return result;
            }
            return string.Empty;
        }
    }
}
