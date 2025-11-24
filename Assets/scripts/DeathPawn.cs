using UnityEngine;

public class DeathPawn : Death
{
    public Pawn pawn;
    public override void Die() {
        SFXManger.Instance.pawnDie();
        pawn.zero();
        GameManger.Instance.lives -= 1;
       
    }

}
