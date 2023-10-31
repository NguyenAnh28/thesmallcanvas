<?php /* Template Name: Pasts Exhibition */ ?>
<?php
get_header();
?>
<main>
    <section class="box-exhibiton">
        <div class="container">
            <div class="content-exhibition">
                <div class="ex-left">
                    <div class="sidebar-ex" data-aos="fade-up">
                        <h2><?php the_title(); ?><span>[<?php
						$count = 0; 

						while ( have_rows('list') ) : the_row();
						    $count++; 
						endwhile;

						echo $count;
						?>]</span></h2>
                    	<?php $i = 1; ?>
                		<?php while ( has_sub_field('list') ) : ?>
                        <div class="avarta <?= $i === 1 ? 'active' : ''; ?>" id="ex-<?= $i; ?>"><img src="<?php the_sub_field('image'); ?>" class="img-fluid" alt="<?php the_sub_field('title'); ?>"></div>
                        <?php $i++; ?>
						<?php endwhile; ?>
                    </div>
                </div>
                <div class="ex-right">
                    <div class="list-exhibition">
                    <?php $i = 1; ?>
                	<?php while ( has_sub_field('list') ) : ?>
                        <div class="item-exh" data-aos="fade-up">
                            <div class="head-ard <?= $i === 1 ? 'active' : ''; ?>" data-tab="ex-<?= $i; ?>">
                                <span><strong><?php the_sub_field('title'); ?></strong></span>
                                <p><?php the_sub_field('description'); ?></p>
                                <div class="icon">
                                    <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                                        <path d="M12 2C6.48 2 2 6.48 2 12C2 17.52 6.48 22 12 22C17.52 22 22 17.52 22 12C22 6.48 17.52 2 12 2ZM15.53 13.03L12.53 16.03C12.38 16.18 12.19 16.25 12 16.25C11.81 16.25 11.62 16.18 11.47 16.03L8.47 13.03C8.18 12.74 8.18 12.26 8.47 11.97C8.76 11.68 9.24 11.68 9.53 11.97L11.25 13.69V8.5C11.25 8.09 11.59 7.75 12 7.75C12.41 7.75 12.75 8.09 12.75 8.5V13.69L14.47 11.97C14.76 11.68 15.24 11.68 15.53 11.97C15.82 12.26 15.82 12.74 15.53 13.03Z" fill="#181818"/>
                                    </svg>
                                </div>
                            </div>
                            <div class="answer"  style="<?= $i === 1 ? 'display: block' : ''; ?>">
                                <?php the_sub_field('content'); ?>
                            </div>
                        </div>
                    <?php $i++; ?>
					<?php endwhile; ?>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>
<?php
get_footer();
?>