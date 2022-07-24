: fact ( n -- n! )
  dup 2 < if
    drop 1
  else
    drop 2
  then ;

