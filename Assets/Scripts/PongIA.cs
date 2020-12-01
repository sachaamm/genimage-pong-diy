using UnityEngine;

public class PongIA : MonoBehaviour
{
    public GameObject ball;
    private Vector3 ballPos;

    public float rangeToTrackBall = 5;
    public float paddleSpeed = 0.5f; 
    
    // Update is called once per frame
    void Update()
    {
        // Suivre le mouvement de la balle
        // en se mettant sur la valeur y de la balle
        ballPos = ball.transform.position;
        
        if (transform.position.x - ballPos.x < rangeToTrackBall)
        {
            FollowBall();
        }
        
     }

    void FollowBall()
    {
        // On met a jour iaPaddlePos
        Vector3 iaPaddlePos = transform.position;
        Vector3 goalPaddlePos = 
            new Vector3(iaPaddlePos.x, ballPos.y, iaPaddlePos.z);

        Vector3 lerpIaPaddlePos =
            Vector3.Lerp(iaPaddlePos, goalPaddlePos, paddleSpeed * Time.deltaTime);
        
        // On assigne (=) transform position a lerpIaPaddlePos
        transform.position = lerpIaPaddlePos;
        
    }
}
