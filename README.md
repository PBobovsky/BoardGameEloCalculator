# BoardGameEloCalculator

For now a very simple tool. 
In theory it should behave like a self balancing rating (similar to ELO) but the calculation is a little bit different. Will likely change the way it is calculated in time, to be a little more correct.
For now the calculation is 
newScore =  max(25+0.1*(abs(loser.Elo-winner.Elo)),5)


Known issues:
Scrollbar is broke
