
public class weapon {

	private float [] fireRate;
	private float [] damage;
	private float [] damageRange;
	private float [] range;
	private float [] splash;
	private float [] pierce;
	private float [] critChance;
	private float [] critMult;
	private float [] ammoUse;
	private float [] otherStat;
	private float [][] weaponProgression; // [ammo][each stat]


	private string [] ammoName;
	private float movePenalty;
	private aimType [] weapSpec;
	private int magSize;
	private float reloadTime;



	public enum damageType{FLAME, PIERCE, BLUNT}
	private enum aimType{HITSCAN, CONE, PATH, MINE, GRENADE	}

	public weapon(float [] newFire, float [] newDamage, float [] newDmgRange, float [] newRange,
		float [] newSplash, float [] newPierce, float newCritCh, float newCritMul,
		float [][] newProgress, string [] newAmmoName, float movePenalty, int newAimType, float [] newOther){
		fireRate = newFire;
		damage = newDamage;
		damageRange = newDmgRange;
		range = newRange;
		splash = newSplash;
		pierce = newPierce;
		critChance = newCritCh;
		critMult = newCritMul;
		weaponProgression = newProgress;
		ammoName = newAmmoName;
		weapSpec = (aimType) newAimType;
		otherStat = newOther;
	}

	private int weaponLevel;

	enum ammoType {}

	private ammoType thisType;

	public float [] getWeapon (){
		float [] myRet = new float[8];
		myRet [0] = fireRate [thisType] + (weaponProgression [thisType] [0] * weaponLevel);
		myRet [1] = damage [thisType] + (weaponProgression [thisType] [1] * weaponLevel);
		myRet [2] = damageRange [thisType] + (weaponProgression [thisType] [2] * weaponLevel);
		myRet [3] = range [thisType] + (weaponProgression [thisType] [3] * weaponLevel);
		myRet [4] = splash [thisType] + (weaponProgression [thisType] [4] * weaponLevel);
		myRet [5] = pierce [thisType] + (weaponProgression [thisType] [5] * weaponLevel);
		myRet [6] = critChance[thisType] + (weaponProgression [thisType] [6] * weaponLevel);
		myRet [7] = critMult[thisType] + (weaponProgression [thisType] [7] * weaponLevel);

	}

	public float [] getProgression(){
		float[] myRet = {weaponProgression [thisType] [0], weaponProgression [thisType] [1], 
			weaponProgression [thisType] [2], weaponProgression [thisType] [3],
			weaponProgression [thisType] [4], weaponProgression [thisType] [5],
			weaponProgression [thisType] [6], weaponProgression [thisType] [7]};
		return myRet;
	}

	public string getAmmoName(){return ammoName [thisType];}

	public void changeAmmo(int numChange){thisType = numChange;}

	public void increaseLevel(){weaponLevel++;}

	public void setLevel(int newLevel){weaponLevel = newLevel;}

	public float getMovePenalty(){return movePenalty;}

	public float [] getOther(){return otherStat;}

	// Use this for initialization

	

}
