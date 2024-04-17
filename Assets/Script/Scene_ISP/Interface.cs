using UnityEngine;


public interface IUnitAllStatus
{

    public float Health { get; set; }

    public int Defense { get; set; }

    public void TakeDamage();

    public float MoveSpeed { get; set; }

    public void GoForward();

    public int Strength { get; set; }

    public int Dexterity {  get; set; }

}

public interface IMovable
{
    public float MoveSpeed { get; set; }

    public void GoForward();

}

public interface IDamageable
{
    public float Health { get; set; }

    public int Defense { get; set; }

    public void TakeDamage();

}

public interface IUnitStats
{
    public int Strength { get; set; }

    public int Dexterity { get; set; }

}

public class EnemyUnit : MonoBehaviour, IDamageable, IMovable, IUnitStats
{
    #region 일반 유닛


    public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Defense { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public float MoveSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Strength { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Dexterity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void GoForward()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }



    #endregion
}

public class UnDeadEnemyUnit : MonoBehaviour, IMovable, IUnitStats
{
    #region 데미지를 받지 않는 유닛
    public float MoveSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Strength { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Dexterity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void GoForward()
    {
        throw new System.NotImplementedException();
    }
    #endregion

}


