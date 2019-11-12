#include "stdafx.h"
#include "tiredness.h"
#include "MiningForGold.h"

tiredness::tiredness()
{
}
tiredness::~tiredness()
{
}
void tiredness::Execute(Miner* miner)
{
	//Print out information on what it is doing...
	cout << "Sleep" << endl;

	//Increment the miner's gold amount
	miner->m_tiredness++;

	if (miner->m_tiredness == 21) // If the miner tiredness is 21 he will get back to work
	{
		miner->ChangeState(new MiningForGold());
	}


}