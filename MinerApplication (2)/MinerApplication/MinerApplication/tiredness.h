#pragma once
#include "State.h"
class tiredness :
	public State
{
public:
	tiredness();
	~tiredness();

	void Execute(Miner* miner);
};
