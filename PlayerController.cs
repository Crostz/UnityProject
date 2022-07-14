RigibBody rb;

// Input added;
Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);

if(rb != null)
{
  rb.velocity = direction * 4;
}



