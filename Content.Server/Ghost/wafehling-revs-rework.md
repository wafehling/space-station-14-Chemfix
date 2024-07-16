# Revs Rework

| Designers | Implemented | GitHub Links |
|---|---|---|
| wafehling | :x: No | TBD |

The purpose of this proposal is to define a deep, yet achievable rework of the Revs gamemode. 

## The Current State of Revs

Here is how most rev rounds go, in my experience. 

```mermaid
flowchart TD
    A[Headrevs spawn roundstart, with no knowledge or way of easily communicating with other headrevs/revs (BAD)] --> B;
    B[Immediate goals are to convert as many people as quickly as possible (BAD), with little discrmination of who (BAD) besides meta-targeting cargo and science (BAD) for flashes, the only way of converting (BAD)] --> C{The first few conversions are...};
	C -->|Good at the revs metagame| D[...competent underlings who don't raise the alarm. Someone brings the headrev a duffel bag full of flashes, and they mass-convert the station rapidly (BAD)] --> F;]
	C -->|Bad at the revs metagame| E[...eager to cause violence, sloppy, or indifferent to the cause. The revs are discovered as the largely seperate headrevs get desperate and are caught trying to steal flashes on their own (VERY BAD), or by an eager recruit jabbing a spear into the captain while screaming about revolution 10 seconds after conversion, blowing the whole operation for everyone (VERY BAD).] -- > G
    F[The brand new army largely ignores the headrev, and a large roaming group of them sloppily murder a headrev and spark violence on their own, (BAD), or begins openly causing chaos and murdering sec/command/mindshielded crew (VERY BAD)] --> H;
    G[Sec, command, and any mindshielded crew instantly start a campaign of murder/mindshielding anyone who doesn't drop their weapons and surrender, the headrevs are quickly murdered or captured (As good as death if they try to mindshield you), and the round ends quickly, violently, and unsatisfyingly (VERY BAD)]
    H[Any command/Sec caught unprepared are quickly murdered/gibbed (VERY BAD), and the round goes on for an indeterminate amount of time while the rest are hunted down, sometimes quite a long time, while the growing army of ghosts watches (VERY BAD)]
```

## Problems

It sounds pretty bleak, but I believe with a few reasonable, mostly borrowed-code changes, Revs can be a more RP-friendly, enjoyable, and varied mode.

1. *The flash/mindshield meta.*
	Both in the sense of "If you can get a giant pile of flashes/mindshields you win" and "If you see someone holding a flash you announce it and it's all over." It's a bad holdover that's easily replaced with something better and more balanced.
	
2. *Excessive, unpenalized violence on both sides*
	Revs snowballing into a mob that can and does murder anyone is not good roleplay or gameplay. Command enacting martial law and telling sec to go on a shooting spree the second they get a whiff of revs is not good roleplay or gameplay. Lose-Lose.
	
3. *Headrevs are unable to easily communicate with one another or their conversions.*
	Headrevs don't know of one another unless they randomly meet, can't talk to each other except in person or in code over common radio, and can't give proper orders or control their subjects in any way. The revolution will not be televised, but there might be a better way...
	
4. *Revs as a general gamemode is very easy to metagame*
	If you know what you're doing as a headrev, you can get half the station converted before the captain has put his socks on. On the contrary, if you're a wily captain, you can see a single flash in someone's hand a minute in and throw the alarm.

## Solutions

### Revolutionary Spirit (Another kind of Rev)

	The Revenant (often confused in-game for revolutionaries) is a minor midround antag, an evil spirit that tries to steal the souls of the sleeping, dead, and dying, converting those souls into *Essence.* While it is not currently in an unfinished state, with no goals, objectives, and only a few unbalanced powers, it is a FANTASTIC framework for *Revolutionary Spirit.* 
	
### No More Flashes

	"Revolutionary Spirit" is much like *Essence.* Headrevs all start with a shared pool of Spirit that all revs can see, and can spend it to activate/use abilities, such as conversion. Spirit steadily recharges, forcing revs to play at a somewhat steadier pace. but it is stored and adds up, so when it's needed you have it, with time. Can't mass-convert the station right away, can't get stuck without flashes/conversion indefinitely.
	
### Give Peace a Chance

	-You're supposed to be bringing these people over to your side, not murdering them!
	-Spirit replenishes steadily by default. Any violent acts done by revolutionaries against crew causes a temporary dip in the rate of replenishment, going down steadily as damage is increased.
	-Conversely, any violent acts done by mindshielded crew/sec/command causes a temporary rise.
	-Handcuffed/jailed revs/unshielded crew causes a dip in Spirit until they are freed/converted. (Even just being In Sec would be enough of a check?)
	-Conversely, captured and alive mindshielded/sec/heads causes a rise in Spirit.
	
	Basically: If one side or the other chooses to go the murderbone route, there will be consequences. It might work, but violence has its cost.
	
### Cool New Toys

	-Other powers, such as the ability to convert even mindshielded crew/sec/command, break cuffs like a freedom implant, stun/flash/silence those around you, gain a temporary speed boost, and more, can be unlocked and used with enough Spirit.
	-Revs either get their own channel, or perhaps communicate with their subjects like the Queen from RMC14, in rev-only announcements. No more wildly varying, incompatible plans and never even seeing your fellow leaders, now you can organize.
	-Command and Sec get an ability called Pacify, or Deconvert, or Loyalize, that is essentially like giving a user a mindshield. This ability could take longer based on the current Spirit rates, what rank the user holds, etc.

*All of these proposed changes have precedent in the codebase and have been implemented in similar ways. In other words, a better mode IS possible.*



	
	