using UnityEngine;


public interface ability{


	bool levelUp ();
	bool activate();
	bool use (target setTarget);
	bool cancel();

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

	public abstract bool levelUp();
	public abstract bool activate(); // use to change the cursor after clicking the ability
	public abstract bool use (target setTarget);  // after clicking on a target, the ability is used on that target
	public abstract bool cancel(); // stops activated


}

public abstract class classAbilities{

	protected abilityStore [] myAbilities;


}

public class abilityTest : abilityStore{
	override public bool levelUp(){
		curLevel++;
	}
}

// Doctor
public class doctorAbilities : classAbilities{
	
	private class treatWound : abilityStore{

		override public bool levelUp(){
			if (Input.GetKeyDown ("Self Target")) {


			} else {


			}

		}

	}


}

