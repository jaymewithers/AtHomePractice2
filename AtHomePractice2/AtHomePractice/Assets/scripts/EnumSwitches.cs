using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitches : MonoBehaviour
{
   public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
   public UnityEvent startEvent, playEvent, inStoreEvent, pauseEvent, endEvent;
   
   public enum GameStates
   {
      Start, Play, InStore, Pause, End
   }

   public GameStates currentGameStates;
   
   public enum PlayerStates
   {
      Idle, Walk, Run, Jump
   }

   public PlayerStates currentPlayerStates;

   public void ChangeStateToPlay()
   {
      currentGameStates = GameStates.Play;
   }

   public void ChangeStateToPause()
   {
      currentGameStates = GameStates.Pause;
   }

   public void ChangeStateToInStore()
   {
      currentGameStates = GameStates.InStore;
   }

   public void ChangeStateToEnd()
   {
      currentGameStates = GameStates.End;
   }

   private void Update()
   {
      switch (currentPlayerStates)
      {
         case PlayerStates.Idle:
            idleEvent.Invoke();
            break;
         case PlayerStates.Walk:
            walkEvent.Invoke();
            break;
         case PlayerStates.Run:
            runEvent.Invoke();
            break;
         case PlayerStates.Jump:
            jumpEvent.Invoke();
            break;
         default:
            print("I am any.");
            break;
      }

      switch (currentGameStates)
      {
         case GameStates.Start:
            startEvent.Invoke();
            break;
         case GameStates.Play:
            playEvent.Invoke();
            break;
         case GameStates.InStore:
            inStoreEvent.Invoke();
            break;
         case GameStates.Pause:
            pauseEvent.Invoke();
            break;
         case GameStates.End:
            endEvent.Invoke();
            break;
         default:
            throw new ArgumentOutOfRangeException();
      }
   }
}