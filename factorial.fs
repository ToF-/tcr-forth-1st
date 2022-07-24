: fact ( n -- n! )
  dup 2 < if
    drop 1
  else
    1+ 1 1 -rot
    do i * loop
  then ;

: factr ( n -- n! )
  drop 1 ;

