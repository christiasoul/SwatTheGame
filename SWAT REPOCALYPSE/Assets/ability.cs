using UnityEngine;


public interface ability{


	bool LevelUp ();
	bool Activate();
	bool Use (target setTarget);
	bool Cancel();

	// Use this for initialization

}

public abstract class abilityStore : ability{
	
	protected int curLevel;
	protected int maxLevel;
	protected float curTime;
	protected float cooldown;
	protected string abilityName;
	protected target.unitType [] typeTargatables;
	protected byte teamTargatables;
	protected float windUpTime;
	protected float followThrough;

	public abstract bool LevelUp();
	public abstract bool Activate(); // use to change the cursor after clicking the ability
	public abstract bool Use (target setTarget);  // after clicking on a target, the ability is used on that target
	public abstract bool Cancel(); // stops activated


}

public abstract class classAbilities{

	protected abilityStore [] myAbilities;


}

public abstract class attack : ability {

	public enum aimType{HITSCAN, CONE, PATH, MINE, GRENADE, MELEE}
	protected weaponHeld myWeapon;
	protected float timeUntilActive;

	public override bool LevelUp(){ return false;}
	public abstract bool Activate(); // use to change the cursor after clicking the ability
	public abstract bool Use (target setTarget);  // after clicking on a target, the ability is used on that target
	public abstract bool Cancel(); // stops activated

	public abstract int GetAimType ();

	public bool IncreaseAmmoLevel (){

	}

	public bool DecreaseAmmoLevel (){

	}

	public bool SetAmmoLevel (){

	}

}

public class abilityTest : abilityStore{
	override public bool LevelUp(){
		curLevel++;
	}
}

// Doctor
public class doctorAbilities : classAbilities{
	
	private class treatWound : abilityStore{

		override public bool LevelUp(){
			if (Input.GetKeyDown ("Self Target")) {


			} else {


			}

		}

	}


}

