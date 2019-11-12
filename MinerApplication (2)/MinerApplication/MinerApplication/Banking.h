#pragma once
#include "State.h"
class Banking :
	public State
{
public:
	Banking();
	~Banking();

	void Execute(Miner* miner);
};