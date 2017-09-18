
public class weaponInfo {

	private string weaponName;

	private const int numOfGrowth = 10;

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
	private float [] windUpTime;
	private float [] followThroughTime;


	public enum damageType{FLAME, PIERCE, BLUNT}
	public enum aimType{HITSCAN, CONE, PATH, MINE, GRENADE, MELEE}

	public weaponInfo(string newWeaponName, float [] newFire, float [] newDamage, float [] newDmgRange, float [] newRange,
		float [] newSplash, float [] newPierce, float newCritCh, float newCritMul, float [] newOther,
		float [][] newProgress, string [] newAmmoName, float movePenalty, int newAimType, 
		int newAmmoSize, float newAmmoReload, int newAmmoUse, float [] newWindUp, float [] newFollowThrough ){

		weaponName = newWeaponName;
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
		magSize = newAmmoSize;
		reloadTime = newAmmoReload;
		windUpTime = newWindUp;
		followThroughTime = newFollowThrough;

	}

	public weaponInfo(int ammoNum){
		
		fireRate = new float[ammoNum];
		damage = new float[ammoNum];
		damageRange = new float[ammoNum];
		range = new float[ammoNum];
		splash = new float[ammoNum];
		pierce = new float[ammoNum];
		critChance = new float[ammoNum];
		critMult = new float[ammoNum];
		ammoUse = new float[ammoNum];
		otherStat = new float[ammoNum];
		weaponProgression = new float[numOfGrowth][ammoNum];
		ammoName = new string[ammoNum];
		weapSpec = new aimType[ammoNum];
		windUpTime = new float[ammoNum];
		followThroughTime = new float[ammoNum];

	}

	public float [] getWeapon (int ammoType, int weaponLevel){
		float [] myRet = new float[8];
		myRet [0] = fireRate [ammoType] + (weaponProgression [ammoType] [0] * weaponLevel);
		myRet [1] = damage [ammoType] + (weaponProgression [ammoType] [1] * weaponLevel);
		myRet [2] = damageRange [ammoType] + (weaponProgression [ammoType] [2] * weaponLevel);
		myRet [3] = range [ammoType] + (weaponProgression [ammoType] [3] * weaponLevel);
		myRet [4] = splash [ammoType] + (weaponProgression [ammoType] [4] * weaponLevel);
		myRet [5] = pierce [ammoType] + (weaponProgression [ammoType] [5] * weaponLevel);
		myRet [6] = critChance[ammoType] + (weaponProgression [ammoType] [6] * weaponLevel);
		myRet [7] = critMult[ammoType] + (weaponProgression [ammoType] [7] * weaponLevel);
		return myRet;
	}

	public float [] getProgression(int ammoType){
		return weaponProgression [ammoType];
	}

	public void decreaseLevel(){weaponLevel--;}

	public string getWeaponName(){return weaponName;}

	public string getAmmoName(int ammoNum){return ammoName [ammoNum];}

	public void changeAmmo(int numChange){thisType = numChange;}

	public void increaseLevel(){weaponLevel++;}

	public void setLevel(int newLevel){weaponLevel = newLevel;}

	public float getMovePenalty(){return movePenalty;}

	public float [] getOther(){return otherStat;}

	// Use this for initialization

	

}
